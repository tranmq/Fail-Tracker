using System.Web.Mvc;

namespace FailTracker.Web.Controllers
{
	[Authorize]
	public abstract class AuthorizedFailTrackerController : FailTrackerController
	{
		
	}
}