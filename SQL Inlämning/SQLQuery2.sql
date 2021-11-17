/****** Script for SelectTopNRows command from SSMS  ******/
--SELECT TOP (1000) [id]
--      ,[first_name]
--      ,[last_name]
--      ,[email]
--      ,[username]
--      ,[password]
--      ,[country]
--  FROM [master].[dbo].[MOCK_DATA]

  --select count(password) from [master].[dbo].[MOCK_DATA]
  --group by password
  --having count(*) < 2500

  --SELECT count(*) as u
  --from [master].[dbo].[MOCK_DATA]
  --where country in ('Sweden', 'Denmark','Norway',
  --'Finland', 'Iceland')
  --group by country
  --having count(*) > 0

  --SELECT count (*)
  --from [master].[dbo].[MOCK_DATA]
  --group by country 
  --having count(*) > 1
  SELECT top 1 country, count(id) AS users
 FROM [master].[dbo].[MOCK_DATA]
 GROUP BY country
 order by count(id) desc
