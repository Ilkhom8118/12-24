using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP;

public class Resturant
{
    public int Id { get; set; }               // Restoranning unikal identifikatori
    public string Name { get; set; }          // Restoran nomi
    public string Address { get; set; }       // Restoran manzili
    public string PhoneNumber { get; set; }   // Telefon raqami
    public string Email { get; set; }         // Elektron pochta
    public string Website { get; set; }       // Veb-sayt
    public string OpeningHours { get; set; }  // Ish vaqti
    public string Description { get; set; }   // Restoran haqida qisqa tavsif
    public bool IsOpenNow { get; set; }       // Hozirda ochiq/ochiq emasligini bildiradi
    public decimal Price { get; set; }        // Taom narxi
}



