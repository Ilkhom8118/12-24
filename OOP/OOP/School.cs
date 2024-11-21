namespace OOP;

internal class School
{
    public int Id { get; set; }                   // Maktabning unikal identifikatori
    public string Name { get; set; }             // Maktab nomi
    public string Address { get; set; }          // Maktab manzili
    public string Principal { get; set; }        // Maktab direktori ismi
    public string PhoneNumber { get; set; }      // Telefon raqami
    public string Email { get; set; }            // Elektron pochta
    public string Website { get; set; }          // Veb-sayt (agar mavjud bo‘lsa)
    public int ClassId { get; set; }             // Sinf identifikatori
    public string NameClass { get; set; }        // Fan nomi (masalan: "Matematika", "Fizika")
    public string TeacherName { get; set; }      // Ushbu fan o‘qituvchisi

}
