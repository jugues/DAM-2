package com.example.videoviewmejorado;

import androidx.appcompat.app.AppCompatActivity;

import android.media.MediaPlayer;
import android.net.Uri;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.MediaController;
import android.widget.Toast;
import android.widget.VideoView;

public class MainActivity extends AppCompatActivity {

    private Button btnRepro;
    private VideoView vvVideo;
    private MediaController mc;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        btnRepro = findViewById(R.id.btnRepro);
        vvVideo = findViewById(R.id.vvVideo);
        mc = new MediaController(this);

        btnRepro.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                int aleatorio = (int)Math.floor(Math.random() * 2); //manejaremos nºs entre 0 y 1
                int identificadorRecurso;
                if(aleatorio == 0)
                {
                    identificadorRecurso = R.raw.ys;
                }

                else
                {
                    identificadorRecurso = R.raw.elMasPerron;
                }

                String rutaVideo = "android.resource://com.example.videoviewmejorado/" + identificadorRecurso;
                Uri uri = Uri.parse(rutaVideo);
                vvVideo.setVideoURI(uri);
                vvVideo.setMediaController(mc);
                vvVideo.start();

                vvVideo.setOnErrorListener(new MediaPlayer.OnErrorListener() {
                    @Override
                    public boolean onError(MediaPlayer mp, int what, int extra) {

                        Toast.makeText(getApplicationContext(), "Ha habido un error de reproducción", Toast.LENGTH_SHORT);
                        return false;
                    }
                });

            }
        });
    }
}