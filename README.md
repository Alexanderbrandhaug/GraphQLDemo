To set up proper backup solutions for your C# project, especially since you're working with .NET Core and ASP.NET Core features, I recommend the following approach:
### 1. **Backup Options**
   - For a small to medium-sized database like SQL Server:
     - Use **SQL Server Management Studio** to manually back up data.
     - Set up scheduled tasks  to perform regular backups.
   - For more automation and larger databases, consider using third-party tools like:
     - **SQL Anytime Backup & Replication**
     - **Acronis**
### 2. **Steps to Implement:**
#### A. Using SQL Server Backup with Scheduled Tasks
1. **Open SQL Server Management Studio :**
   - Connect to your database.
   - Navigate to the **Backup** tab.
2. **Create a Backup Schedule:**
   - Go to **Schedule** > **Tasks**.
   - Add a new task for your backup:
     - **Target:** Set it to `Local` if you want backups stored on your machine, or `Network`  for remote storage.
     - **Schedule Time:** Choose the frequency .
     - **Backup Database:** Select your database.
3. **Restore from Backup:**
   - For point-in-time recovery, use SQL Anytime:
     - Open SQL Anytime and go to **File** > **Database Settings** > **Restore**.
     - browse to the backup file location and restore.
#### B. Using Third-Party Tools 
For more complex scenarios or larger databases, tools like **SQL Anytime Backup & Replication** or **Acronis** can automate:
   - Full backups
   - Incremental data changes
   - Point-in-time recovery
### 3. **Cost Considerations**
- **Free Tools:** SQL Server Backups  and SQL Anytime are often sufficient for small projects.
- **Third-Party Solutions:** Acronis, SQL Anytime, or others may offer more features but come with a cost.
Let me know if you need further assistance!