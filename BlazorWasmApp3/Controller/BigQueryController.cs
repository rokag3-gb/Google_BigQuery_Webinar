using Google.Cloud.BigQuery.V2;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Bigquery.v2.Data;
using Google.Apis.Bigquery.v2;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWasmApp3.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class BigQueryController
    {
        string _projectId = "cloudmate-sdteam";
        string _projectName = "SD Team";
        string _datasetId = "ds01";
        string _datasetName = "ds01";
        string _tableId = "tb1";
        string _tableName = "tb1";

        GoogleCredential credential_SDTeam = GoogleCredential.FromJson(
            @"{
            ""type"": ""service_account"",
            ""project_id"": ""cloudmate-sdteam"",
            ""private_key_id"": ""1060cb22333347bdb688c841a8af6953696fbc53"",
            ""private_key"": ""-----BEGIN PRIVATE KEY-----\nMIIEvAIBADANBgkqhkiG9w0BAQEFAASCBKYwggSiAgEAAoIBAQCfBA50n0RU7ZWV\nMmvY4K5kFJ/TssXqo18dp5hw2ykbPXNPwHawSJv9PnFo3KTVfZ28aOrHiFRbJV7B\nEqSDHprYZ8DeG7tezl0rfc0FvxGYvPKDbonYZcGVnztUVbLdPlvEhjP9wWos3Py3\n6IehA/NSaHKzwz+wLjII3+0lWsPxgLxdxF5XpLwj1MRDw4D5UR241k4NaL3556W3\neQoUr831ULNooH9vG0bdwiM611Pao7mjyA0nudwSH26Pt82di/b4siC4b3p1IPn3\nM1KLQezW+bnVHA3576SJxVIq7cosK4ye6iMrAj+Rn+ilyMSnalb1wqf6rD908akf\n2BaWwYNrAgMBAAECggEAExuGrSbSLC5cUhA7+1SMQARmbCbIN3ioHkUcQTtkhhxt\nNcEXwfkHnXeaYxJYUDsG8DPfOli8YjNsXmDiGctcqfJVr5q/ehXsBiTYtP8Pmz3h\nGj/3GmSnzVXT6D9f/cvXdRb3Ol+6ZWesimDLo2J5I4bfeZBVn9L9OinGMj3k26j+\n0CTWD01rJd+YEr9eKGl0/KpaWF0E8jgHNnXTi0CN2psIZsTLoZNi3o4vZJ6HlsYr\neVQ0fCbMrJueP0OvjzMnQh2A80z2/GkS+fp8L7IOvp+7gCVkfQMGwG4SbJCPfmC7\nujWwE8lUkkPaNZB1fltkQ7BevMoHAHXepL8GKOyoCQKBgQDbhp/O3uRDY34Fs7RM\nzL4ZrbyQ95Lx8zrJaI2xc8BsLj3rjsQ33MNKgbYMwObfWbOPurHBOcJSeiQDkr4g\nDfysnur6ALWJZwCW6hBsUSIOUJ1IZ1ltII3brNcB0LrPdFw/yQHYrTuqXvaXPMW8\nLuTDdHvGxmoBAKrWMvrB6REPPwKBgQC5b65z1d8crepMtXYxKHVStWYIzjVT5skp\nNMgbgtyvufnxwpxjc47gkTIoASRtsxsQ7Z27EAaoyb4D4HfQgrIoFB8En4sOTNUW\nAXvFSmctZkKgswFyDpz9QD+WpXScahvBYN2FgqN+v4EnwQWIyRzZEcEH2dRPFRj7\n/smJV88s1QKBgCznxvzsP0lBqt/DuNgU8bYTAgWtfxObK6VTi9iG0w/ODcCHvb+n\nmxM8oV7OfuulT8PQ7teV1xhD/+XzOI0aD1vITkzBpGDs/wPf8WgW2J6RAvtymKpo\nBFyxaHHonq4dIVmy5nvKQ/A/6LVbKx+pgAYzZ7Zrk/eMiWWzm/PalzDFAoGAdetC\nCWEoZullQ/Bkv2/V44l83/6ZRMhOhUiOM4hs48Yk3gr+PfO/GKjcNzo6uxOZE5O2\nqLzRL0ZS8c4tAsgJmJjq/Jqj560OF9dLqLLel60ek2ghdDE8vYK8rQR7+fczvS3m\n0D65zyDidbA137zb/mFe2ao4ay2kXKKx8AeJtB0CgYA7d/UDu1NZZAM2ZAIekLFb\nLK3Pfs2cIRK9EJLnnGF7A8a6LQFVw5KnN+umX2M2+8Deac4abylpLbbudRyRMvZz\nhNTMHb4OKSE9iGCXMHKFqEQusndwreB26qNBcr3DwrDv2/6tDrpQlNMnGyoAH94K\nHc3I91AOSByvMPp6hJnv4Q==\n-----END PRIVATE KEY-----\n"",
            ""client_email"": ""svc-acc-sd-team-bigquery@cloudmate-sdteam.iam.gserviceaccount.com"",
            ""client_id"": ""106497119766159198079"",
            ""auth_uri"": ""https://accounts.google.com/o/oauth2/auth"",
            ""token_uri"": ""https://oauth2.googleapis.com/token"",
            ""auth_provider_x509_cert_url"": ""https://www.googleapis.com/oauth2/v1/certs"",
            ""client_x509_cert_url"": ""https://www.googleapis.com/robot/v1/metadata/x509/svc-acc-sd-team-bigquery%40cloudmate-sdteam.iam.gserviceaccount.com""
            }");

        string query = @"
                select	col1
	                , colString
	                , CURRENT_TIMESTAMP() as TIMESTAMP
	                , DATETIME(CURRENT_TIMESTAMP(), 'Asia/Seoul') as datetime_KST
	                , DATETIME(CURRENT_TIMESTAMP(), 'America/Los_Angeles') AS datetime_LA
	                , DATE(2023, 4, 4) AS date_ymd
	                , DATETIME(DATETIME '2023-04-04 23:59:59') AS date_dt
	                , generate_uuid() as UUID
	                , 'asd' as VAL1
                from	`ds01.tb1`;
                ";
        
        [Route("/bigquery/Select_tb1TestData/")]
        [HttpGet]
        public async Task<BigQueryResults?> Select_tb1TestData()
        {
            BigQueryResults result;

            try
            {
                BigQueryClient client = BigQueryClient.Create(_projectId, credential_SDTeam);

                result = client.ExecuteQuery(query, parameters: null);

                client.Dispose();

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
    }
}