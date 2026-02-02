USE RazorPagesDemo;
GO

-- ASP.NET Identity Tables (Minimal set)
CREATE TABLE Roles (
Id NVARCHAR(450) NOT NULL PRIMARY KEY,
Name NVARCHAR(256) NULL,
NormalizedName NVARCHAR(256) NULL,
ConcurrencyStamp NVARCHAR(MAX) NULL
);


CREATE TABLE Users (
Id NVARCHAR(450) NOT NULL PRIMARY KEY,
UserName NVARCHAR(256) NULL,
NormalizedUserName NVARCHAR(256) NULL,
Email NVARCHAR(256) NULL,
NormalizedEmail NVARCHAR(256) NULL,
EmailConfirmed BIT NOT NULL,
PasswordHash NVARCHAR(MAX) NULL,
SecurityStamp NVARCHAR(MAX) NULL,
ConcurrencyStamp NVARCHAR(MAX) NULL,
PhoneNumber NVARCHAR(MAX) NULL,
PhoneNumberConfirmed BIT NOT NULL,
TwoFactorEnabled BIT NOT NULL,
LockoutEnd DATETIMEOFFSET NULL,
LockoutEnabled BIT NOT NULL,
AccessFailedCount INT NOT NULL
);


CREATE TABLE UserRoles (
UserId NVARCHAR(450) NOT NULL,
RoleId NVARCHAR(450) NOT NULL,
PRIMARY KEY (UserId, RoleId),
FOREIGN KEY (UserId) REFERENCES Users(Id) ON DELETE CASCADE,
FOREIGN KEY (RoleId) REFERENCES Roles(Id) ON DELETE CASCADE
);


CREATE TABLE UserClaims (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    UserId NVARCHAR(450) NOT NULL,
    ClaimType NVARCHAR(256),
    ClaimValue NVARCHAR(1024),
    FOREIGN KEY (UserId) REFERENCES Users(Id)
);

CREATE TABLE RoleClaims (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    RoleId NVARCHAR(450) NOT NULL,
    ClaimType NVARCHAR(256),
    ClaimValue NVARCHAR(1024),
    FOREIGN KEY (RoleId) REFERENCES Roles(Id)
);

CREATE TABLE UserLogins (
    LoginProvider NVARCHAR(128) NOT NULL,
    ProviderKey NVARCHAR(128) NOT NULL,
    ProviderDisplayName NVARCHAR(256),
    UserId NVARCHAR(450) NOT NULL,
    PRIMARY KEY (LoginProvider, ProviderKey),
    FOREIGN KEY (UserId) REFERENCES Users(Id)
);

CREATE TABLE UserTokens (
    UserId NVARCHAR(450) NOT NULL,
    LoginProvider NVARCHAR(128) NOT NULL,
    Name NVARCHAR(128) NOT NULL,
    Value NVARCHAR(MAX),
    PRIMARY KEY (UserId, LoginProvider, Name),
    FOREIGN KEY (UserId) REFERENCES Users(Id)
);


-- Insert Roles
INSERT INTO Roles (Id, Name, NormalizedName)
VALUES
(NEWID(), 'Admin', 'ADMIN'),
(NEWID(), 'Maintainer', 'MAINTAINER'),
(NEWID(), 'ReadOnly', 'READONLY');

