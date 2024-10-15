using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Person> guest_list = new List<Person>();

Person p1 = new Person("Guest 1");
Person p2 = new Person("Guest 2");

guest_list.Add(p1);
guest_list.Add(p2);

// Cria a suíte
Suite suite_obj = new Suite( "Premium", 2, 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reservation reservation_obj = new Reservation(reservationDays: 5);
reservation_obj.RegisterSuite(suite_obj);
reservation_obj.RegisterGuests(guest_list);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Guest: {reservation_obj.GetGuestCount()}");
Console.WriteLine($"Daily Value: {reservation_obj.CalculateDailyValue()}");