using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FintrakBanking.Repositories.Queries
{
    public class LoanQueries
    {
        public const string GetCustomerUUS = @"
SELECT
    e.Id              AS ChecklistId,
    e.Item,
    e.Description,
    e.CheckTypes,

    s.[Option]        AS SystemOption,
    s.ReviewalComment AS SystemComment,

    r.OfficerOption,
    r.OfficerComment,
    r.ReviewedBy,
    r.ReviewedAt
FROM st_NmrcEligibility e
LEFT JOIN tbl_CustomerUUS s
    ON s.ItemId = e.Id
   AND s.EmployeeNhfNumber = @NhfNumber
LEFT JOIN TblCustomerUUSReview r
    ON r.ItemId = e.Id
   AND r.EmployeeNhfNumber = @NhfNumber
WHERE e.IsActive = 1
and e.Category = 1
ORDER BY e.Id";

    public const string GetCustomerUUSResults = @"
SELECT
    e.Id           AS ChecklistId,
    e.Item,
    e.Description,
    e.CheckTypes,

    COALESCE(r.OfficerOption, s.[Option]) AS FinalOption,

    COALESCE(r.OfficerComment, s.ReviewalComment) AS FinalComment,

    r.ReviewedBy,
    r.ReviewedAt
FROM StNmrcEligibility e
LEFT JOIN TblCustomerUUS s
    ON s.ItemId = e.Id
   AND s.EmployeeNhfNumber = @NhfNumber
LEFT JOIN TblCustomerUUSReview r
    ON r.ItemId = e.Id
   AND r.EmployeeNhfNumber = @NhfNumber
WHERE e.IsActive = 1

AND (
    (e.CheckTypes = 'AUTO'   AND s.Id IS NOT NULL)
 OR (e.CheckTypes = 'MANUAL' AND r.Id IS NOT NULL)
 OR (e.CheckTypes = 'HYBRID' AND r.Id IS NOT NULL)
)
ORDER BY e.Id";

    }


}
