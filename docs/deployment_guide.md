
# Install helm charts

## Install Sql Server

```bash
$ helm install sqlserver stable/mssql-linux --debug --namespace dev --values sqlserver/values.dev.yaml
```

```bash
$ kubectl run mssqlcli --image=microsoft/mssql-tools -ti --restart=Never --rm=true -- /bin/bash
$ sqlcmd -S sqlserver -U sa
```

```sql
CREATE DATABASE CoolStoreDb
GO

SELECT name FROM sys.databases
GO
```

## Install Zipkin

```bash
$ helm upgrade --namespace dev --install --wait zipkin zipkin
```

## Install Seq

```bash
$ helm install seq stable/seq --debug --namespace dev --values sqlserver/values.dev.yaml
```
