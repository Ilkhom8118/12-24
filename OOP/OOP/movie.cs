namespace OOP;

internal class movie
{
    public int Id { get; set; }                // Filmning unikal identifikatori
    public string Title { get; set; }          // Film nomi
    public string Director { get; set; }       // Rejissyor ismi
    public string Genre { get; set; }          // Janr (masalan: "Fantastika", "Drama")
    public int Duration { get; set; }          // Davomiylik (daqiqalarda)
    public string Language { get; set; }       // Til (masalan: "Inglizcha", "O‘zbekcha")
    public string Country { get; set; }        // Ishlab chiqarilgan mamlakat
    public decimal Budget { get; set; }        // Filmning byudjeti
    public decimal BoxOffice { get; set; }     // Kassadan tushgan daromad
    public string Rating { get; set; }         // Reyting (masalan: "PG-13", "R")
}
