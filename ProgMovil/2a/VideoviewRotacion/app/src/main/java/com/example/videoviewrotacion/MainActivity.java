package com.example.videoviewrotacion;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.media.MediaPlayer;
import android.net.Uri;
import android.os.Bundle;
import android.provider.MediaStore;
import android.util.Log;
import android.widget.MediaController;
import android.widget.Toast;
import android.widget.VideoView;

public class MainActivity extends AppCompatActivity {

    private VideoView vv;
    private int position = 0;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        vv = findViewById(R.id.vvVideo);

        establishVideo();
    }

    private void establishVideo()
    {
        String rutaVideo = "android.resource://com.example.videoviewmejorado/" + R.raw.ys;
        Uri uri = Uri.parse(rutaVideo);
        MediaController mc = new MediaController(this);
        vv.setMediaController(mc);

        try {
            vv.setVideoURI(uri);
            vv.requestFocus();
            }

        catch(Exception ex)
        {
            Log.e("Error: ", ex.getMessage());
            ex.printStackTrace();
        }

        vv.setOnPreparedListener(new MediaPlayer.OnPreparedListener() {
            @Override
            public void onPrepared(MediaPlayer mp) {
                mp.setLooping(true);

                if(position == 0)
                {
                    vv.start();
                }

                else //el vídeo ya se estaba reproduciendo
                {
                    vv.pause();
                }
            }
        });

        vv.setOnErrorListener(new MediaPlayer.OnErrorListener() {
            @Override
            public boolean onError(MediaPlayer mp, int what, int extra) {

                Toast.makeText(getApplicationContext(), "Ha habido un error de reproducción", Toast.LENGTH_SHORT);
                return false;
            }
        });
    }

    @Override
    protected void onSaveInstanceState(@NonNull Bundle outState) { //salvar posición del vídeo antes de girar

        super.onSaveInstanceState(outState);
        outState.putInt("miPosicion", vv.getCurrentPosition());
        vv.pause();
    }

    @Override
    protected void onRestoreInstanceState(@NonNull Bundle savedInstanceState) //volver el vídeo al punto en el que estaba
    {
        super.onRestoreInstanceState(savedInstanceState);
        position = savedInstanceState.getInt("miPosicion");
        vv.seekTo(position);
    }
}