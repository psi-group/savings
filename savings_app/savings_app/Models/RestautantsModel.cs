namespace savings_app.Models
{
	public class RestautantsModel
	{
		public string Name{ get; private set; }
		public string Address { get; private set; }
		public bool Status { get; set; }
		public int PositionCount { get; set; }
		public string SiteRef { get; set; }

	}

}
