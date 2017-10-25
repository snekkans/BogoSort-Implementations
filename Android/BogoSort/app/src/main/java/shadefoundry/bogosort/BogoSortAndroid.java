package shadefoundry.bogosort;

import android.content.DialogInterface;
import android.support.v7.app.AlertDialog;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import org.w3c.dom.Text;

import java.util.ArrayList;
import java.util.List;
import java.util.Random;

import static shadefoundry.bogosort.Bogosort.bogoSort;

public class BogoSortAndroid extends AppCompatActivity {
    int numValuesToGenerate = 0;
    String arrayString = "[";
    List<Integer> values = new ArrayList<Integer>();
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_bogo_sort);
        Button btn_go = (Button)findViewById(R.id.btn_startSorting);
        btn_go.setEnabled(false);
    }

    public void beginSorting(View view) {
        TextView txt_timesShuffled = (TextView)findViewById(R.id.txt_timesShuffled);
        Button btn_generateArray = (Button)findViewById(R.id.btn_generateArray);
        Button btn_go = (Button)findViewById(R.id.btn_startSorting);
        //btn_generateArray.setEnabled(false);
        int howLong = bogoSort(values);

        //txt_timesShuffled.setText(howLong);
        //cry("It took "+howLong+" tries to sort the array "+arrayString);
        sendMessage("It took "+howLong+" tries to sort the array "+arrayString);
        btn_generateArray.setEnabled(true);
        btn_go.setEnabled(false);

    }

    private void sendMessage(String s) {
        AlertDialog alertDialog = new AlertDialog.Builder(BogoSortAndroid.this).create();
        alertDialog.setTitle("Results");
        alertDialog.setMessage(s);
        alertDialog.setButton(AlertDialog.BUTTON_POSITIVE, "Awesome!",
                new DialogInterface.OnClickListener() {
                    public void onClick(DialogInterface dialog, int which) {
                        dialog.dismiss();
                    }
                });
        alertDialog.show();
    }

    public void generateArray(View view) {
        TextView txt_displayArray = (TextView)findViewById(R.id.txt_generatedArray);
        boolean fine = checkValues();

        if(!fine){
            values.clear();
            arrayString = "[";
            txt_displayArray.setText("No array yet!");
            cry("You need to enter a valid number!");
        }
        else{
            List<Integer> list = buildArray(numValuesToGenerate);
            txt_displayArray.setText(arrayString);
        }
    }

    private List<Integer> buildArray(int numValuesToGenerate) {
        Button btn_go = (Button)findViewById(R.id.btn_startSorting);
        arrayString = "[";
        values.clear();
        Random rnd = new Random();
        for(int i=0;i<numValuesToGenerate;i++){
            int nxtRnd = rnd.nextInt(99)+1;
            values.add(nxtRnd);
            arrayString += Integer.toString(nxtRnd);
            if (i != numValuesToGenerate - 1) { arrayString += ", "; }
        }
        arrayString += "]";
        btn_go.setEnabled(true);
        System.out.println(arrayString);
        return values;
    }

    //general method to make toasts to save time coding later
    private void cry(String s) {
        Toast toast = Toast.makeText(getApplicationContext(),s,Toast.LENGTH_SHORT);
        toast.show();
    }

    private boolean checkValues() {
        numValuesToGenerate = 0;
        EditText editText_numValuesToGenerate = (EditText) findViewById(R.id.editTxt_numValuesToGenerate);
        String inputValue = editText_numValuesToGenerate.getText().toString();

        //try to convert the string to an int. If something goes wrong set it to 0
        try{numValuesToGenerate = Integer.parseInt(inputValue);}
        catch (Exception e){numValuesToGenerate = 0;}

        //if the number to generate is 0 throw an error
        if(numValuesToGenerate==0||numValuesToGenerate>100){return false;}
        //if the value is bigger than 6, we're probably going to
        // crash so we should probably let the user know
        else if(numValuesToGenerate>6){
            cry("More than 6 values PROBABLY CRASH, fair warning!");
            return true;
        }
        //otherwise proceed with the madness
        else{return true;}
    }
}
