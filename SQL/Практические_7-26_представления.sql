/* =====================================================================
   Скрипт к практическим работам 7, 13, 14, 17, 26.
   Выполнять в SSMS на вашей базе (в script.sql она называется Wow_Meow).
   Если база называется MarathonSkillsDB — замените имя в строке USE.
   ===================================================================== */
USE [Wow_Meow]
GO

/* ---------- Практическая 13, задание 2: марафон текущего года ---------- */
IF NOT EXISTS (SELECT 1 FROM dbo.Marathon WHERE MarathonId = 6)
BEGIN
    SET IDENTITY_INSERT dbo.Marathon ON;
    INSERT dbo.Marathon (MarathonId, MarathonName, CityName, CountryCode, YearHeld)
    VALUES (6, N'Marathon Skills 2016', N'Екатеринбург', N'RUS', 2016);
    SET IDENTITY_INSERT dbo.Marathon OFF;
END
GO

/* Виды забегов марафона 2016 (без них в форме 5 «Регистрация на марафон»
   список «Вид марафона» будет пустым) */
IF NOT EXISTS (SELECT 1 FROM dbo.Event WHERE MarathonId = 6)
INSERT dbo.Event (EventId, EventName, EventTypeId, MarathonId, StartDateTime, Cost, MaxParticipants) VALUES
 (N'16_6FM', N'Ural Full Marathon',     N'FM', 6, '2016-09-03T06:00:00', 145.00, 2000),
 (N'16_6HM', N'Ural Half Marathon',     N'HM', 6, '2016-09-03T07:00:00',  75.00, 2500),
 (N'16_6FR', N'Ekaterinburg 5km Fun Run', N'FR', 6, '2016-09-03T15:00:00',  20.00, 5000);
GO

/* ---------- Практическая 7, задание 2: представление RunnerView2 ---------- */
IF OBJECT_ID(N'dbo.RunnerView2', N'V') IS NOT NULL DROP VIEW dbo.RunnerView2;
GO
CREATE VIEW dbo.RunnerView2
AS
SELECT dbo.Registration.RegistrationId, dbo.[User].FirstName, dbo.[User].LastName,
       dbo.RegistrationEvent.BibNumber, dbo.Country.CountryCode, dbo.Charity.CharityName
FROM   dbo.RegistrationEvent
       INNER JOIN dbo.Registration ON dbo.RegistrationEvent.RegistrationId = dbo.Registration.RegistrationId
       INNER JOIN dbo.Runner       ON dbo.Registration.RunnerId = dbo.Runner.RunnerId
       INNER JOIN dbo.[User]       ON dbo.Runner.Email = dbo.[User].Email
       INNER JOIN dbo.Country      ON dbo.Runner.CountryCode = dbo.Country.CountryCode
       INNER JOIN dbo.Charity      ON dbo.Registration.CharityId = dbo.Charity.CharityId
WHERE  (dbo.RegistrationEvent.BibNumber IS NOT NULL)
GO

/* ---------- Практическая 13, задание 2: «Фильтр Marathon Skills» ---------- */
IF OBJECT_ID(N'dbo.[Фильтр Marathon Skills]', N'V') IS NOT NULL DROP VIEW dbo.[Фильтр Marathon Skills];
GO
CREATE VIEW dbo.[Фильтр Marathon Skills]
AS
SELECT dbo.Event.EventId, dbo.Marathon.MarathonId, dbo.EventType.EventTypeName, dbo.Event.Cost
FROM   dbo.Event
       INNER JOIN dbo.EventType ON dbo.Event.EventTypeId = dbo.EventType.EventTypeId
       INNER JOIN dbo.Marathon  ON dbo.Event.MarathonId = dbo.Marathon.MarathonId
WHERE  (dbo.Marathon.MarathonId = 6)
GO

/* ---------- Практическая 14, задание 2: «Мои результаты» ---------- */
IF OBJECT_ID(N'dbo.[Мои результаты]', N'V') IS NOT NULL DROP VIEW dbo.[Мои результаты];
GO
CREATE VIEW dbo.[Мои результаты]
AS
SELECT dbo.Marathon.MarathonName, dbo.EventType.EventTypeName, dbo.RegistrationEvent.RaceTime,
       dbo.Runner.RunnerId, dbo.Marathon.MarathonId, dbo.Event.EventId
FROM   dbo.Marathon
       INNER JOIN dbo.Event             ON dbo.Marathon.MarathonId = dbo.Event.MarathonId
       INNER JOIN dbo.EventType         ON dbo.Event.EventTypeId = dbo.EventType.EventTypeId
       INNER JOIN dbo.RegistrationEvent ON dbo.Event.EventId = dbo.RegistrationEvent.EventId
       INNER JOIN dbo.Registration      ON dbo.RegistrationEvent.RegistrationId = dbo.Registration.RegistrationId
       INNER JOIN dbo.Runner            ON dbo.Registration.RunnerId = dbo.Runner.RunnerId
GO

/* ---------- Практическая 17, задание 2: runnerManage ---------- */
IF OBJECT_ID(N'dbo.runnerManage', N'V') IS NOT NULL DROP VIEW dbo.runnerManage;
GO
CREATE VIEW dbo.runnerManage
AS
SELECT dbo.[User].FirstName, dbo.[User].LastName, dbo.[User].Email,
       dbo.RegistrationStatus.RegistrationStatus, dbo.Runner.RunnerId, dbo.Marathon.MarathonId,
       dbo.RegistrationStatus.RegistrationStatusId, dbo.Runner.Gender, dbo.Event.EventId,
       dbo.Event.EventTypeId, dbo.EventType.EventTypeName
FROM   dbo.Marathon
       INNER JOIN dbo.Event              ON dbo.Marathon.MarathonId = dbo.Event.MarathonId
       INNER JOIN dbo.EventType          ON dbo.Event.EventTypeId = dbo.EventType.EventTypeId
       INNER JOIN dbo.RegistrationEvent  ON dbo.Event.EventId = dbo.RegistrationEvent.EventId
       INNER JOIN dbo.Registration       ON dbo.RegistrationEvent.RegistrationId = dbo.Registration.RegistrationId
       INNER JOIN dbo.RegistrationStatus ON dbo.Registration.RegistrationStatusId = dbo.RegistrationStatus.RegistrationStatusId
       INNER JOIN dbo.Runner             ON dbo.Registration.RunnerId = dbo.Runner.RunnerId
       INNER JOIN dbo.[User]             ON dbo.Runner.Email = dbo.[User].Email
       INNER JOIN dbo.Country            ON dbo.Runner.CountryCode = dbo.Country.CountryCode
GO

/* ---------- Практическая 26, задание 2: «Предыдущие результаты» ---------- */
IF OBJECT_ID(N'dbo.[Предыдущие результаты]', N'V') IS NOT NULL DROP VIEW dbo.[Предыдущие результаты];
GO
CREATE VIEW dbo.[Предыдущие результаты]
AS
SELECT dbo.RegistrationEvent.RaceTime, dbo.[User].FirstName, dbo.[User].LastName, dbo.Country.CountryName,
       dbo.Runner.RunnerId, dbo.Runner.Email, dbo.Event.EventId, dbo.Event.EventTypeId,
       dbo.Runner.Gender, dbo.Marathon.MarathonId, dbo.Runner.DateOfBirth
FROM   dbo.Marathon
       INNER JOIN dbo.Event             ON dbo.Marathon.MarathonId = dbo.Event.MarathonId
       INNER JOIN dbo.EventType         ON dbo.Event.EventTypeId = dbo.EventType.EventTypeId
       INNER JOIN dbo.RegistrationEvent ON dbo.Event.EventId = dbo.RegistrationEvent.EventId
       INNER JOIN dbo.Registration      ON dbo.RegistrationEvent.RegistrationId = dbo.Registration.RegistrationId
       INNER JOIN dbo.Runner            ON dbo.Registration.RunnerId = dbo.Runner.RunnerId
       INNER JOIN dbo.[User]            ON dbo.Runner.Email = dbo.[User].Email
       INNER JOIN dbo.Country           ON dbo.Runner.CountryCode = dbo.Country.CountryCode
WHERE  (dbo.RegistrationEvent.RaceTime IS NOT NULL) AND (dbo.RegistrationEvent.RaceTime > 0)
GO

/* Проверка */
SELECT TOP 5 * FROM dbo.RunnerView2;
SELECT * FROM dbo.[Фильтр Marathon Skills];
SELECT TOP 5 * FROM dbo.[Мои результаты];
SELECT TOP 5 * FROM dbo.runnerManage;
SELECT TOP 5 * FROM dbo.[Предыдущие результаты];
GO
