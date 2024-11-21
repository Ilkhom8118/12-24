namespace OOP;

internal class Home
{
    public int Id { get; set; }                  // Uy identifikatori
    public string Address { get; set; }         // Manzil
    public int NumberOfRooms { get; set; }      // Xonalar soni
    public double Area { get; set; }            // Maydoni (kv.m)
    public int NumberOfFloors { get; set; }     // Qavatlar soni
    public int YearBuilt { get; set; }          // Qurilgan yili
    public string Type { get; set; }            // Uy turi (Masalan: "Villa", "Kvartira", "Bog‘ uyi")
    public decimal Price { get; set; }          // Narxi
    public bool IsAvailable { get; set; }       // Sotuvga/turar joy uchun mavjudligi
    public string Neighborhood { get; set; }   // Mahalla
}
