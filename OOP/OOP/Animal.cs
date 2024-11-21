namespace OOP;

internal class Animal
{
    public int Id { get; set; }             // Hayvonning unikal identifikatori
    public string Name { get; set; }        // Hayvonning ismi
    public string Species { get; set; }     // Hayvon turi (masalan, "It", "Mushuk", "Quyon")
    public string Breed { get; set; }       // Zoti (agar mavjud bo‘lsa)
    public string Color { get; set; }       // Rang
    public int Age { get; set; }            // Yoshi
    public double Weight { get; set; }      // Vazni (kg yoki boshqa o‘lchov birligida)
    public string Gender { get; set; }      // Jinsi ("Erkak", "Urg‘ochi")
    public bool IsDomesticated { get; set; } // Uy hayvoni yoki yo‘q (true/false)
    public string FavoriteFood { get; set; } // Eng yoqtirgan ovqat
}
