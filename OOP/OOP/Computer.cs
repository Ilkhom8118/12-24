namespace OOP;

internal class Computer
{
    public int Id { get; set; }                  // Kompyuterning unikal identifikatori
    public string Brand { get; set; }           // Ishlab chiqaruvchi kompaniya nomi (masalan: "Dell", "Apple")
    public string Model { get; set; }           // Model nomi (masalan: "MacBook Pro", "Inspiron 15")
    public string Processor { get; set; }       // Protsessor turi (masalan: "Intel Core i7", "AMD Ryzen 5")
    public int RAM { get; set; }                // Operativ xotira (GB)
    public int Storage { get; set; }            // Ichki xotira hajmi (GB yoki TB)
    public string StorageType { get; set; }     // Xotira turi (masalan: "SSD", "HDD")
    public string GraphicsCard { get; set; }    // Videokarta turi (masalan: "NVIDIA RTX 3060", "Integrated")
    public double ScreenSize { get; set; }      // Ekran o‘lchami (inch)
    public string OperatingSystem { get; set; } // Operatsion tizim (masalan: "Windows 11", "macOS")
    public decimal Price { get; set; }          // Narxi
}
