package com.example.reproduccionsonidocontrolado;

import androidx.appcompat.app.AppCompatActivity;

import android.media.MediaPlayer;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class MainActivity extends AppCompatActivity {

    Button b;
    MediaPlayer m;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        b = findViewById(R.id.btnPlayPause);
        m = MediaPlayer.create(this, R.raw.cancion);

        b.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if(m.isPlaying())
                {
                    m.pause();
                    b.setBackgroundResource(R.drawable.play);
                }

                else
                {
                    m.start();
                    b.setBackgroundResource(R.drawable.pause);
                }
            }
        });
    }
}