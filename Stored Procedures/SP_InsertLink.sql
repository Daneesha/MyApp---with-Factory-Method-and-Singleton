SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:  Daneesha
-- Create date: 05 Feb 2022
-- Description: Insert link
-- =============================================

CREATE PROCEDURE SP_InsertLink
	@ID INT,
	@Name NVARCHAR(200),
	@Line NVARCHAR(200)
	
AS
BEGIN

   SET NOCOUNT ON;

   INSERT INTO	Link
   VALUES		(@ID,
				@Name,
				@Line
				);

END
GO