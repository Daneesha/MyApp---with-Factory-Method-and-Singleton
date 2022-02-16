USE [MyAppFactoryMethod]
GO

/****** Object:  StoredProcedure [dbo].[SP_UpdateQuote]    Script Date: 2/12/2022 11:52:39 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:  Daneesha
-- Create date: 12 Feb 2022
-- Description: Update quote by ID
-- =============================================

CREATE PROCEDURE [dbo].[SP_UpdateQuote]
	@ID INT,
	@Date DATETIME,
	@Line NVARCHAR(200),
	@Author NVARCHAR(100)
	
AS
BEGIN

   SET NOCOUNT ON;

   UPDATE	Quote
   SET		Date = @Date,
			Line = @Line,
			Author = @Author
   WHERE	ID = @ID;

END
GO


