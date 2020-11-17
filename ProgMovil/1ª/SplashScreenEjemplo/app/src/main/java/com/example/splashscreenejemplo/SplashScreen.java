package com.example.splashscreenejemplo;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;

import java.util.Timer;
import java.util.TimerTask;

public class SplashScreen extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_splash_screen);

        getSupportActionBar().hide();

        TimerTask task = new TimerTask() {
            @Override
            public void run() {
                Intent mainIntent = new Intent().setClass(SplashScreen.this, MainActivity.class); //actividad de origen y actividad de llegada
                startActivity(mainIntent);
                //cerramos la actividad actual
                finish();
            }
        };

        Timer t = new Timer();
        t.schedule(task, 5000);
    }
}