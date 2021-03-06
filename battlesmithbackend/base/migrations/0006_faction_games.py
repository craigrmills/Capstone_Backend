# Generated by Django 3.2.7 on 2021-09-20 14:42

from django.conf import settings
from django.db import migrations, models
import django.db.models.deletion


class Migration(migrations.Migration):

    dependencies = [
        migrations.swappable_dependency(settings.AUTH_USER_MODEL),
        ('base', '0005_review_createdat'),
    ]

    operations = [
        migrations.CreateModel(
            name='Faction',
            fields=[
                ('name', models.CharField(blank=True, max_length=200, null=True)),
                ('numPlayed', models.IntegerField(blank=True, default=0, null=True)),
                ('winRate', models.IntegerField(blank=True, default=0, null=True)),
                ('_id', models.AutoField(editable=False, primary_key=True, serialize=False)),
            ],
        ),
        migrations.CreateModel(
            name='Games',
            fields=[
                ('p1Score', models.IntegerField(blank=True, default=0, null=True)),
                ('p2Score', models.IntegerField(blank=True, default=0, null=True)),
                ('_id', models.AutoField(editable=False, primary_key=True, serialize=False)),
                ('loser', models.ForeignKey(null=True, on_delete=django.db.models.deletion.SET_NULL, related_name='winner', to=settings.AUTH_USER_MODEL)),
                ('p1Faction', models.ForeignKey(null=True, on_delete=django.db.models.deletion.SET_NULL, related_name='p1Faction', to='base.faction')),
                ('p2Faction', models.ForeignKey(null=True, on_delete=django.db.models.deletion.SET_NULL, related_name='p2Faction', to='base.faction')),
                ('player1', models.ForeignKey(null=True, on_delete=django.db.models.deletion.SET_NULL, related_name='player1', to=settings.AUTH_USER_MODEL)),
                ('player2', models.ForeignKey(null=True, on_delete=django.db.models.deletion.SET_NULL, related_name='player2', to=settings.AUTH_USER_MODEL)),
                ('winner', models.ForeignKey(null=True, on_delete=django.db.models.deletion.SET_NULL, related_name='loser', to=settings.AUTH_USER_MODEL)),
            ],
        ),
    ]
