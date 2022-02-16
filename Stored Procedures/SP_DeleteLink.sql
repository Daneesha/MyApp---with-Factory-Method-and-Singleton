USE [MyAppFactoryMethod]
GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteLink]    Script Date: 2/12/2022 11:31:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:  Daneesha
-- Create date: 12 Feb 2022
-- Description: Delete link by ID
-- =============================================

CREATE PROCEDURE [dbo].[SP_DeleteLink]
	@ID INT
		
AS
BEGIN

   SET NOCOUNT ON;

   DELETE	Link
   WHERE	ID = @ID;

END
