namespace OOP;

internal class Game
{
    public int Id { get; set; }                // Oʻyinning unikal identifikatori
    public string Title { get; set; }          // Oʻyin nomi
    public string Genre { get; set; }          // Janr (masalan: "Action", "RPG", "Shooter")
    public string Developer { get; set; }      // Ishlab chiqaruvchi kompaniya
    public string Publisher { get; set; }      // Nashriyotchi kompaniya
    public decimal Price { get; set; }         // Narxi
    public string Platform { get; set; }       // Platforma (masalan: "PC", "PlayStation", "Xbox")
    public string ESRBRating { get; set; }     // Reyting (masalan: "E", "T", "M")
    public double SizeInGB { get; set; }       // Fayl hajmi (GB)
    public bool IsMultiplayer { get; set; }    // Koʻp oʻyinchilik rejimi mavjudligi
    public int RAM { get; set; }               // Operativ xotira (GB)
}
