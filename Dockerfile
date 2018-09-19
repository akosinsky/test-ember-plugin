FROM flexberry/mono-ember as backend

ENV PROJECT=Product_23527

COPY $PROJECT /backend-src/

RUN	cd /backend-src ; \
	nuget restore $PROJECT.sln ; \
	msbuild /p:Configuration=Release $PROJECT.sln ;


FROM danlynn/ember-cli:2.4.3 as frontend

COPY ember-app/vendor /ember-app/vendor

RUN	cd /ember-app ; \
	ember init ; \
	npm install ; \
	bower install  --allow-root ; \
	ember install ember-flexberry ; \
	npm install ; \
	bower install  --allow-root ; \
	ember generate flexberry-application app --metadata-dir=vendor/flexberry ; \
	ember build ; \
	echo done

FROM flexberry/alt.p8-apache2-mono:latest

RUN	rm -r /var/www/vhosts/test

COPY --from=backend /backend-src/ODataBackend /var/www/vhosts/test
COPY --from=frontend /ember-app/dist /var/www/vhosts/test
