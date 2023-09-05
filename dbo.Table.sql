CREATE TABLE [dbo].[tbl_User] (
    [userID]       INT          NOT NULL,
    [userName]     VARCHAR (50) NOT NULL,
    [userPassword] VARCHAR (50) NOT NULL,
    [userType]     VARCHAR (50) NOT NULL,
    [userStatus]   VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([userID] ASC)
);


