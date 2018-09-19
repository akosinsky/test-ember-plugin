docker build -f Dockerfile-application -t flexberry/apps/product_23527:latest --rm ../
docker build -f Dockerfile-postgres -t flexberry/postgres/product_23527:latest --rm ../
docker image prune -f
