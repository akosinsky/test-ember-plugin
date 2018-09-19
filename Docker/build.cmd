rem docker build -f Dockerfile-application -t flexberry/apps/product_23527:latest --rm ../
docker build --no-cache -f Dockerfile-postgres -t flexberry/postgres/product_23527:latest --rm ../
rem docker image prune -f
