namespace app.Model
{
    public class TodoItem
    {
        public int id { get; set; }
        public string Name   { get; set; }
        public bool isCompleted { get; set; }
        public bool isdeleted {  get; set; }=false;

    }
}
