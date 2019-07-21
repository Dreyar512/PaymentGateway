CREATE TABLE [dbo].[payment] (
    [paymentID]  INT           IDENTITY (1, 1) NOT NULL,
    [cardNumber] NVARCHAR (25) NULL,
    [date]       NVARCHAR (10) NULL,
    [amount]     INT           NULL,
    [currency]   NVARCHAR (10) NULL,
    [cvv]        INT           NULL,
    [reference]  NVARCHAR (50) NULL,
    [status]     NVARCHAR (15) NULL,
    PRIMARY KEY CLUSTERED ([paymentID] ASC)
);

