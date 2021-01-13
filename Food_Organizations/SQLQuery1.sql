ALTER TABLE dbo.Meals_Menu
   CONSTRAINT [FK_Meals_Menu_ToTable_2] FOREIGN KEY (Food_Type) REFERENCES [dbo].[Food_Type](Food_Type)
