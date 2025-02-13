using System;

namespace TicketReservationSystem
{
    class Ticket
    {
        public int TicketID { get; set; }
        public string CustomerName { get; set; }
        public string MovieName { get; set; }
        public int SeatNumber { get; set; }
        public DateTime BookingTime { get; set; }
        public Ticket Next { get; set; } // Points to next node
    }

    class TicketReservation
    {
        private Ticket head;

        // Add a new ticket at the end
        public void AddTicket(int id, string customer, string movie, int seat)
        {
            Ticket newTicket = new Ticket
            {
                TicketID = id,
                CustomerName = customer,
                MovieName = movie,
                SeatNumber = seat,
                BookingTime = DateTime.Now,
                Next = null
            };

            if (head == null)
            {
                head = newTicket;
                head.Next = head; // Circular linking
            }
            else
            {
                Ticket temp = head;
                while (temp.Next != head)
                {
                    temp = temp.Next;
                }
                temp.Next = newTicket;
                newTicket.Next = head;
            }
        }

        // Remove a ticket by ID
        public void RemoveTicket(int id)
        {
            if (head == null)
            {
                Console.WriteLine("No tickets booked.");
                return;
            }

            Ticket current = head, prev = null;

            do
            {
                if (current.TicketID == id)
                {
                    if (prev == null)
                    {
                        // Removing head node
                        Ticket last = head;
                        while (last.Next != head)
                        {
                            last = last.Next;
                        }
                        if (head == head.Next)
                        {
                            head = null;
                        }
                        else
                        {
                            head = head.Next;
                            last.Next = head;
                        }
                    }
                    else
                    {
                        prev.Next = current.Next;
                    }
                    Console.WriteLine("Ticket removed successfully.");
                    return;
                }
                prev = current;
                current = current.Next;
            } while (current != head);

            Console.WriteLine("Ticket not found.");
        }

        // Display all tickets
        public void DisplayTickets()
        {
            if (head == null)
            {
                Console.WriteLine("No tickets booked.");
                return;
            }

            Ticket temp = head;
            do
            {
                Console.WriteLine($"Ticket ID: {temp.TicketID}, Customer: {temp.CustomerName}, Movie: {temp.MovieName}, Seat: {temp.SeatNumber}, Booking Time: {temp.BookingTime}");
                temp = temp.Next;
            } while (temp != head);
        }

        // Search tickets by Customer Name or Movie Name
        public void SearchTicket(string keyword)
        {
            if (head == null)
            {
                Console.WriteLine("No tickets booked.");
                return;
            }

            Ticket temp = head;
            bool found = false;

            do
            {
                if (temp.CustomerName.Contains(keyword, StringComparison.OrdinalIgnoreCase) || temp.MovieName.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Ticket ID: {temp.TicketID}, Customer: {temp.CustomerName}, Movie: {temp.MovieName}, Seat: {temp.SeatNumber}, Booking Time: {temp.BookingTime}");
                    found = true;
                }
                temp = temp.Next;
            } while (temp != head);

            if (!found)
            {
                Console.WriteLine("No matching tickets found.");
            }
        }

        // Count total booked tickets
        public int CountTickets()
        {
            if (head == null)
                return 0;

            int count = 0;
            Ticket temp = head;
            do
            {
                count++;
                temp = temp.Next;
            } while (temp != head);

            return count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TicketReservation system = new TicketReservation();

            while (true)
            {
                Console.WriteLine("\n1. Book Ticket\n2. Remove Ticket\n3. Display Tickets\n4. Search Ticket\n5. Count Tickets\n6. Exit");
                Console.Write("Choose an option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Ticket ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Enter Customer Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Movie Name: ");
                        string movie = Console.ReadLine();
                        Console.Write("Enter Seat Number: ");
                        int seat = int.Parse(Console.ReadLine());
                        system.AddTicket(id, name, movie, seat);
                        break;
                    case 2:
                        Console.Write("Enter Ticket ID to remove: ");
                        int removeId = int.Parse(Console.ReadLine());
                        system.RemoveTicket(removeId);
                        break;
                    case 3:
                        system.DisplayTickets();
                        break;
                    case 4:
                        Console.Write("Enter Customer Name or Movie Name to search: ");
                        string searchKey = Console.ReadLine();
                        system.SearchTicket(searchKey);
                        break;
                    case 5:
                        Console.WriteLine("Total Tickets Booked: " + system.CountTickets());
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }
    }
}