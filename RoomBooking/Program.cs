//RoomBooking Lapteva V.V.
using RoomBooking.Logic;
using RoomBooking.Data;

IBookingRepository repository = new DemoBookingRepository();
var service = new BookingService(repository);
Console.WriteLine("Отобранные записи:");
foreach (var item in service.GetImportant())
{
    Console.WriteLine($"{item.Id}: {item.Room}");
}