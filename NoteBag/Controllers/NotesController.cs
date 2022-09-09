using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NoteBag.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public NotesController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IEnumerable<Note> GetNotes()
        {
            return _db.Notes.OrderByDescending(x => x.CreatedTime).ToList();
        }
        [HttpGet("{id}")]
        public ActionResult<Note> GetNote(int id)
        {
            var note = _db.Notes.Find(id);
            if (note == null)
                return NotFound();
            return note;
        }

        [HttpPost]
        public async Task<ActionResult<Note>> PostNote(PostNoteDto dto)
        {
            if (ModelState.IsValid)
            {
                Note note = new Note() { Title = dto.Title, Content = dto.Content};
                _db.Notes.Add(note);
                await _db.SaveChangesAsync();
                return CreatedAtAction("GetNote", new { id = note.Id }, note); 
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Note>> PutNote(int id, PutNoteDto dto)
        {
            if (id != dto.Id)
                return BadRequest();
            var note = _db.Notes.Find(id);
            if (note==null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                note.Title = dto.Title;
                note.Content = dto.Content;
                note.ModifiedTime = DateTime.Now;
                await _db.SaveChangesAsync();
                return Ok(note);
            }
            return BadRequest(ModelState);
        }

        private bool NotesItemExists(int id)
        {
            return _db.Notes.Any(e => e.Id == id);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNote(int id)
        {
            var note = await _db.Notes.FindAsync(id);
            if (note == null)
            {
                return NotFound();
            }
            _db.Notes.Remove(note);
            await _db.SaveChangesAsync();

            return NoContent();
        }
    }
}
