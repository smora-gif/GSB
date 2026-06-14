$connStr = "Server=localhost;Port=3306;Database=gsb_ordonnances;Uid=gsb;Pwd=gsbpass;"
$cnx = New-Object MySql.Data.MySqlClient.MySqlConnection($connStr)
$cnx.Open()
$cmd = New-Object MySql.Data.MySqlClient.MySqlCommand("DESCRIBE MEDICAMENT", $cnx)
$reader = $cmd.ExecuteReader()
while ($reader.Read()) {
    Write-Host $reader.GetString(0) "|" $reader.GetString(1)
}
$cnx.Close()
