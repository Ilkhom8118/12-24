namespace OOP;

internal class Book
{
    public int Id { get; set; }                  // Kitobning unikal identifikatori
    public string Title { get; set; }           // Kitob nomi
    public string Author { get; set; }          // Muallif ismi
    public decimal Price { get; set; }          // Narxi
    public string Genre { get; set; }           // Janr (masalan, "Drama", "Fantastika")
    public int Pages { get; set; }              // Sahifalar soni
    public string Language { get; set; }        // Kitob tili
    public string PublishedDate { get; set; } // Nashr etilgan sana
    public string CoverType { get; set; }       // Muqova turi ("Yumshoq", "Qattiq")
    public string Website { get; set; }         // Nashriyot veb-sayti
}
