using System;

public static class FineCalculator
{
    public static bool TryReadLoan(string[] row, int reportDay, out int readerId, out string name, out int fine, out bool flagged)
    {
        readerId = 0;
        name = "";
        fine = 0;
        flagged = false;

        if (row.Length != 6 ||
            (row[2] != "student" && row[2] != "teacher" && row[2] != "guest")) return false;
        name = row[1];
        for (int i = 0; i < row.Length; i++)
        {
            if (i != 5 && row[i] == "") return false;
        }

        if (!int.TryParse(row[0], out readerId) ||
            !int.TryParse(row[4], out int loanDay)) return false;

        int endDay = reportDay;
        if (row[5] != "" && !int.TryParse(row[5], out endDay)) return false;
        if (endDay < loanDay) return false;

        int borrowedDays = endDay - loanDay;
        if (row[2] == "student")
        {
            int chargeableDays = borrowedDays > 15 ? borrowedDays - 14 : 0;
            fine = Math.Min(30, chargeableDays);
        }
        else if (row[2] == "guest")
        {
            int overdueDays = Math.Max(0, borrowedDays - 7);
            fine = (overdueDays * 5 + 1) / 2;
        }
        else
        {
            flagged = row[5] == "" && borrowedDays > 60;
        }

        return true;
    }
}
