namespace OOP;

internal class Planet
{
    public int Id { get; set; }                  // Sayyoraning unikal identifikatori
    public string Name { get; set; }             // Sayyora nomi (masalan: "Yer", "Mars")
    public double Mass { get; set; }             // Massasi (kilogrammlarda)
    public double Diameter { get; set; }         // Diametri (kilometrda)
    public double Gravity { get; set; }          // Gravitatsiya kuchi (m/s^2)
    public double OrbitalPeriod { get; set; }    // Orbital davri (kunlarda)
    public double RotationPeriod { get; set; }   // Aylanish davri (soatlarda)
    public double DistanceFromSun { get; set; }  // Quyoshdan masofa (million kilometrda)
    public string Type { get; set; }             // Sayyora turi (masalan: "Yer guruhidagi", "Gaz giganti")
    public double Temperature { get; set; }      // Oʻrtacha harorat (°C)
}
