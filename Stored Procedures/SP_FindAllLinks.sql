SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:  Daneesha
-- Create date: 05 Feb 2022
-- Description: Get all links
-- =============================================

CREATE PROCEDURE SP_FindAllLinks
AS
BEGIN
   SET NOCOUNT ON;
   SELECT * FROM Link;
END
GO