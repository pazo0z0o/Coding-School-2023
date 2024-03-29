﻿namespace Session_27.Model { 

public class Transaction
{
    public Transaction()
    {
        Date = DateTime.Now;
        TransactionLines = new List<TransactionLine>();
    }

    public int Id { get; set; }
    public DateTime Date { get; set; }
    public decimal TotalPrice { get; set; }

    // Relations
    public int CustomerId { get; set; }
    public Customer Customer { get; set; } = null!;

    public int ManagerId { get; set; }
    public Manager Manager { get; set; } = null!;

    public int CarId { get; set; }
    public Car Car { get; set; } = null!;

    public List<TransactionLine> TransactionLines { get; set; }
}
}