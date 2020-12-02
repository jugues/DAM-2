package com.example.reproduccionsonido;

import androidx.appcompat.app.AppCompatActivity;

import android.media.MediaPlayer;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class MainActivity extends AppCompatActivity {

    private Button btnReproducir;
    private MediaPlayer media;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        btnReproducir = findViewById(R.id.btnSonido);
        btnReproducir.setOnClickListener(new View.OnClickListener()
                                         {

                                             @Override
                                             public void onClick(View v) {
                                                 media = MediaPlayer.create(getApplicationContext(), R.raw.campana);
                                                 media.start();
                                             }
                                         }

        );
    }
}