SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:  Daneesha
-- Create date: 05 Feb 2022
-- Description: Get all quotes
-- =============================================

CREATE PROCEDURE SP_FindAllQuotes
AS
BEGIN
   SET NOCOUNT ON;
   SELECT * FROM Quote;
END
GO