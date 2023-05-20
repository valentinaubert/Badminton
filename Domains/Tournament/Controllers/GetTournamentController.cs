using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/tournament")]
public class TournamentController : ControllerBase
{ 
    [HttpGet]
    public ActionResult<Tournament> GetTournament()
    {
        var uuid = Guid.NewGuid();
        var name = "tournoi1";
        var date = DateTime.Now;
        var tournament = new Tournament(uuid.ToString(), name, date);

        return tournament;
    }
}