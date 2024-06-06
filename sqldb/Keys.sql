ALTER TABLE [dbo].[TicketsInfo]  WITH CHECK ADD  CONSTRAINT [FK_TicketsInfo_Services] FOREIGN KEY([idService])
REFERENCES [dbo].[Services] ([id])
GO

ALTER TABLE [dbo].[TicketsInfo] CHECK CONSTRAINT [FK_TicketsInfo_Services]
GO

ALTER TABLE [dbo].[TicketsInfo]  WITH CHECK ADD  CONSTRAINT [FK_TicketsInfo_Tickets] FOREIGN KEY([idTicket])
REFERENCES [dbo].[Tickets] ([id])
GO

ALTER TABLE [dbo].[TicketsInfo] CHECK CONSTRAINT [FK_TicketsInfo_Tickets]
GO

ALTER TABLE [dbo].[Tickets]  WITH CHECK ADD  CONSTRAINT [FK_Tickets_Users] FOREIGN KEY([idUser])
REFERENCES [dbo].[Users] ([id])
GO

ALTER TABLE [dbo].[Tickets] CHECK CONSTRAINT [FK_Tickets_Users]
GO
