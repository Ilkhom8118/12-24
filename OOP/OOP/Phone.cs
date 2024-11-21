namespace OOP;

internal class Phone
{
    public int Id { get; set; }                  // Telefonning unikal identifikatori
    public string Brand { get; set; }           // Ishlab chiqaruvchi kompaniya nomi (masalan: "Apple", "Samsung")
    public string Model { get; set; }           // Telefon modeli (masalan: "iPhone 13", "Galaxy S22")
    public string OperatingSystem { get; set; } // Operatsion tizim (masalan: "iOS", "Android")
    public decimal Price { get; set; }          // Telefon narxi
    public string Color { get; set; }           // Rang (masalan: "Qora", "Oq", "Ko'k")
    public string Processor { get; set; }       // Protsessor turi (masalan: "Snapdragon 888", "A15 Bionic")
    public int RAM { get; set; }                // Operativ xotira (GB)
    public int Storage { get; set; }            // Ichki xotira (GB)
    public bool HasExpandableStorage { get; set; } // Xotira kengaytirish imkoniyati (SD-karta)
    public int BatteryCapacity { get; set; }    // Batareya hajmi (mAh)
    public bool Has5G { get; set; }             // 5G texnologiyasi mavjudligi
    public bool HasFingerprintScanner { get; set; } // Barmoq izini skaneri mavjudligi
}
