using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
  
  namespace NationalParksClient.Models
  {
  public class Park
  {
    public int ParkId { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Description { get; set; }
    public int ClimbingRoutes { get; set; }
    public int Campgrounds { get; set; }
    public int GeneralStores { get; set; }

    public static List<Park> GetParks()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Park> parkList = JsonConvert.DeserializeObject<List<Park>>(jsonResponse.ToString());

      return parkList;
    }
  public static Park GetDetails(int id)
    {
      var apiCallTask = ApiHelper.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Park park = JsonConvert.DeserializeObject<Park>(jsonResponse.ToString());

      return park;
    }
  }
}