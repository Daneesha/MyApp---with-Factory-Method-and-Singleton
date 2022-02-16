USE [MyAppFactoryMethod]
GO

/****** Object:  StoredProcedure [dbo].[SP_FindQuoteByID]    Script Date: 2/12/2022 11:47:04 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:  Daneesha
-- Create date: 12 Feb 2022
-- Description: Get quote by ID
-- =============================================

CREATE PROCEDURE [dbo].[SP_FindQuoteByID]
	@ID INT
	
AS
BEGIN

   SET NOCOUNT ON;

   SELECT * FROM Quote
   WHERE ID = @ID;

END
GO


