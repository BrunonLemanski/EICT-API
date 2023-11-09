using eict_api.Models.Harbour;

namespace eict_api.Models.Route
{
    public class RouteEntity
    {
        private int id {  get; set; }
        private HarbourEntity startPoint { get; set; }
        private HarbourEntity endPoint { get; set; }

    }
}
