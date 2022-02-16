USE [MyAppFactoryMethod]
GO

/****** Object:  StoredProcedure [dbo].[SP_DeleteQuote]    Script Date: 2/12/2022 12:14:59 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:  Daneesha
-- Create date: 12 Feb 2022
-- Description: Delete link by ID
-- =============================================

CREATE PROCEDURE [dbo].[SP_DeleteQuote]
	@ID INT
		
AS
BEGIN

   SET NOCOUNT ON;

   DELETE	Quote
   WHERE	ID = @ID;

END
GO


