docker build -t run_sql_demo-image -f Dockerfile2 .

docker run -it --name run_sql_demo-cont  -v ~/SqlDemoCsharp/Logs/:/App/Logs/  -d run_sql_demo-image

