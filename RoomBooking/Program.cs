//RoomBooking Lapteva V.V.
using RoomBooking.Logic;
var service = new BookingService();
Console.WriteLine("Отобранные записи:");
foreach (var item in service.GetImportant())
{
    Console.WriteLine($"{item.Id}: {item.Room}");
}

