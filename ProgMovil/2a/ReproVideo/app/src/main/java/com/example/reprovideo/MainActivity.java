package com.example.reprovideo;

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

    private VideoView v;
    private Button btnReproducir;
    private MediaController mc;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        btnReproducir = findViewById(R.id.btnReproducir);
        v = findViewById(R.id.videoView);

        btnReproducir.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                String ruta = getPackageName() + "/" + R.raw.video;
                v.setVideoURI(Uri.parse("android.resource://" + ruta));
                v.start();

                v.setOnErrorListener(new MediaPlayer.OnErrorListener() {
                    @Override
                    public boolean onError(MediaPlayer mp, int what, int extra) {
                        Toast.makeText(getApplicationContext(), "Algo ha fallado en la reproducción...", Toast.LENGTH_LONG).show();
                        return false;
                    }
                });
            }
        });
    }
}