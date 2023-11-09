namespace eict_api.Models.Route
{
    public class RouteOption
    {
        private int id {  get; set; }
        private string routeType { get; set; }
        private float cost { get; set; }
        private float duration { get; set; }
        private RouteEntity routeEntity { get; set; }
    }
}
