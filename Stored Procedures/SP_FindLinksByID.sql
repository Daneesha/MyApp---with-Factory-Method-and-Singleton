SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:  Daneesha
-- Create date: 05 Feb 2022
-- Description: Get links by ID
-- =============================================

CREATE PROCEDURE SP_FindLinksByID
	@ID INT
	
AS
BEGIN

   SET NOCOUNT ON;

   SELECT * FROM Link
   WHERE ID = @ID;

END
GO