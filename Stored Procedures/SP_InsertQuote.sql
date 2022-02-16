USE [MyAppFactoryMethod]
GO

/****** Object:  StoredProcedure [dbo].[SP_InsertQuote]    Script Date: 2/12/2022 12:10:01 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:  Daneesha
-- Create date: 12 Feb 2022
-- Description: Insert quote
-- =============================================

CREATE PROCEDURE [dbo].[SP_InsertQuote]
	@ID INT,
	@Date DATETIME,
	@Line NVARCHAR(200),
	@Author NVARCHAR(100)
	
AS
BEGIN

   SET NOCOUNT ON;

   INSERT INTO	Quote
   VALUES		(@ID,
				@Date,
				@Line,
				@Author
				);

END
GO


