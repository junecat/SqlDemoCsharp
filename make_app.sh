docker build -t build_sql_demo-image -f Dockerfile .

docker run -it --name build_sql_demo-cont  -v ~/SqlDemoCsharp/publish-output:/App/publish-output -d build_sql_demo-image
