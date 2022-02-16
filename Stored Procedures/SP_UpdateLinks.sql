SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:  Daneesha
-- Create date: 05 Feb 2022
-- Description: Update links by ID
-- =============================================

CREATE PROCEDURE SP_UpdateLinks
	@ID INT,
	@Name NVARCHAR(200),
	@Line NVARCHAR(200)
	
AS
BEGIN

   SET NOCOUNT ON;

   UPDATE	Link
   SET		Name = @Name,
			Line = @Line
   WHERE	ID = @ID;

END
GO