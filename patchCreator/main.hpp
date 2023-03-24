#ifndef __MAIN_H__
#define __MAIN_H__


//#define test



#include <iostream>
#include <cstring>
#include <stdio.h>
#include "common.hpp"
#include "dbc.hpp"

#include <map>
//#include <nlohmann/json.hpp>
#include <fstream>

#include <string>
#include <stdexcept>
#include "mpq.hpp"
//#include <curl/curl.h>

inline unsigned int stringToUInt(const std::string& s)
{
    unsigned long lresult = stoul(s, 0, 10);
    unsigned int result = lresult;
    if (result != lresult) throw std::out_of_range("result not lresult");
    return result;
}

//using json = nlohmann::json;

#define SQL_INSERTS_PER_QUERY 300
#define SLASH_BUFFER2000

DBCFileLoader DBCSpell;
DBCFileLoader DBCCreatureDusplayInfo;
DBCFileLoader DBCItemDisplayInfo;
DBCFileLoader DBCSpellItemEnchantment;

#ifdef test
std::map<uint32, uint32> SpellChange{
    {34161,0},
    {48438,0},
    {308090,0},
    {310187,0},
    {310188,0},
    {310189,0},
    {310190,0},
    {315225,0},
    {308105,0},
    {308113 ,0},
    {311868,0},
    {17,0},
    {592,0},
    {600,0},
    {3747,0},
    {6065,0},
    {6066,0},
    {10898,0},
    {10899,0},
    {10900,0},
    {10901,0},
    {11647,0},
    {11835,0},
    {11974,0},
    {17139,0},
    {20697,0},
    {22187,0},
    {25217,0},
    {25218,0},
    {27607,0},
    {29408,0},
    {32595,0},
    {33147,0},
    {35944,0},
    {36051,0},
    {41373,0},
    {44175,0},
    {44291,0},
    {46193,0},
    {48065,0},
    {48066,0},
    {51723,0},
    {66099,0},
    {68032,0},
    {71548,0},
    {71780,0},
    {302269,0},
    {305082,0},
    {308143,0},
    {308229,0},
    {311845,0},
    {16190,0},
    {16191,0},
    {39609,0},
    {308001,19},
    {308002,19},
    {308003,19},
    {309084,0},
    {309087,0},
    {309229,0},
    {309231,0},
    {309232,0},
    {309233,0},
    {310121,0},
    {13809,0},
    {48818,0},
    {48819,0},
    {311834,0},
    {311839,0},
    {308051,64},
    {308057,64},
    {308062 ,67},
    {316162,0},
    {316367,0},
    {316455,0},
    {316456,0},
    {316457,0},
    {310810,0},
    {310811,0},
    {310812,0},
    {310813,0},
    {310814,0},
    {310815,0},
    {310545,0},
    {310546,0},
    {310547,0},
    {310548,0},
    {310549,0},
    {310550,0},
    {310551,0},
    {310552,0},
    {310553,0},
    {310555,0},
    {310556,0},
    {310560,0},
    {310561,0},
    {310562,0},
    {310563,0},
    {310501,0},
    {310476,0},
    {310477,0},
    {310479,0},
    {310632,0},
    {310633,0},
    {310634,0},
    {310674,0},
    {310658,0},
    {308640,0},
    {308641,0},
    {308642,0},
    {308643,0},
    {308644,0},
    {308645,0},
    {308646,0},
    {308647,0},
    {308648,0},
    {308649,0},
    {308656,0},
    {308636,0},
    {308663,0},
    {308664,0},
    {308665,0},
    {308666,0},
    {308668,0},
    {308669,0},
    {308670,0},
    {308671,0},
    {308552,0},
    {308553,0},
    {308555,0},
    {308556,0},
    {308586,0},
    {308582,0},
    {308565,0},
    {308470,0},
    {308469,0},
    {308475,0},
    {63018,0},
    {63023,0},
    {312586,0},
    {312597,0},
    {312588,0},
    {312589,0},
    {312941,0},
    {312942,0},
    {63387,0},
    {64019,0},
    {64531,0},
    {64532,0},
    {312448,0},
    {312449,0},
    {312801,0},
    {312802,0},
    {63666,0},
    {65026,0},
    {312347,0},
    {312435,0},
    {312700,0},
    {312788,0},
    {61170,0},
    {70123,0},
    {71047,0},
    {71048,0},
    {71049,0},
    {71387,0},
    {300718,0},
    {28531,0},
    {312192,0},
    {312193,0},
    {312198,0},
    {312199,0},
    {312200,0},
    {312202,0},
    {317252,0},
    {317258,0},
    {317253,0},
    {317254,0},
    {319177,0},
    {304798,0},
    {304782,0},
    {304777,0},
    {304778,0},
    {304765,0},
    {304761,0},
    {304811,0},
    {319824,0},
    {319825,0},
    {319826,0},
    {319827,0},
    {312218,0},
    {312219,0},
    {318754,0},
    {64413,0},
    {69055,0},
    {70814,0},
    {69195,0},
    {71219,0},
    {73031,0},
    {73032,0},
    {314953,0},
    {320438,0},
    {318824,0},
    {318828,0},
    {320292,0},
    {319021,0},
    {305515,0},
    {306535,0},
    {306536,0},
    {306554,0},
    {319029 ,15254},
    {310659,15254},
    {310660,15254},
    {310636,15254},
    {310637,15254},
    {308550,15254},
    {308471,15254},
    {308472,15254},
    {312590,15254},
    {312591,15254},
    {312943,15254},
    {312944,15254},
    {63024,15254},
    {63025,15254},
    {308548,15254},
    {309046,15254},
    {309047,15254},
    {309065,15254},
    {310496,15254},
    {310497,15254},
    {310498,15254},
    {310499,15254},
    {310500,15254},
    {63276,15254},
    {63278,15254},
    {312621,15254},
    {312622,15254},
    {312974,15254},
    {312975,15254},
    {317565,15254},
    {317566 ,15254},
    {312208,15254},
    {312209,15254},
    {317160,15254},
    {317161,15254},
    {306487,15254},
    {306488,15254},
    {308750,15254},
    {315046,0},
    {321414,0}
};
#else
std::map<uint32, uint32> SpellChange{};
#endif
std::map<uint32, uint32> CreatureDusplayInfoChange{};
std::map<uint32, uint32> ItemDisplayInfoChange{};
std::map<uint32, uint32> SpellItemEnchantmentChange{};

bool ChangeSpellDBC(std::string);
bool ChangeCreatureDisplayInfoDBC(std::string);
bool ChangeItemDisplayInfoDBC(std::string);
bool ChangeSpellItemEnchantmentDBC(std::string);
bool CreateMPQ(std::string);
bool parseJsons(std::string, std::string);
bool ExtractMPQ(std::string);

int MainFunction(std::string path = "error") {

    parseJsons(path);
    ExtractMPQ(path);

    ChangeSpellDBC(path);
    ChangeCreatureDisplayInfoDBC(path);
    ChangeItemDisplayInfoDBC(path);
    ChangeSpellItemEnchantmentDBC(path);
    CreateMPQ(path);

    //#ifdef WIN32
        //std::cout << "\n\nPlease press Enter to exit...";
        /*getchar();*/
    //#endif

    return 0;
}
static size_t WriteCallback(void* contents, size_t size, size_t nmemb, void* userp) {
    ((std::string*)userp)->append((char*)contents, size * nmemb);
    return size * nmemb;
}
bool parseJsons(std::string path = "error",std::string newJson = "da") {
    //CURL* curl;
    ////CURLcode res;
    //std::string readBuffer;
    //curl = curl_easy_init();
    //if (curl) {
    //    curl_easy_setopt(curl, CURLOPT_URL, "https://raw.githubusercontent.com/fxpw/AddonUpdaterCode/main/patchCreator/jsons/Spell.dbc.parser.json");
    //    curl_easy_setopt(curl, CURLOPT_WRITEFUNCTION, WriteCallback);
    //    curl_easy_setopt(curl, CURLOPT_WRITEDATA, &readBuffer);
    //    curl_easy_perform(curl);
    //    // curl_easy_cleanup(curl);
    //    // Debug::Print(readBuffer);
    //    std::string responce = std::string(readBuffer);
    //}
    //else {
    //    return false;
    //}
    
    /////////////////////
    //std::ifstream f1("./jsons/Spell.dbc.parser.json");
    //json data1 = json::parse(readBuffer);
    //for (json::iterator it = data1.begin(); it != data1.end(); ++it) {
    //    // std::cout << "Spell.dbc add" << it.key() << " " <<it.value() << '\n';
    //    SpellChange[stringToUInt(it.key())] = it.value();
    //}
    /////////////////////
    //std::ifstream f2("./jsons/CreatureDusplayInfo.dbc.json");
    //json data2 = json::parse(f2);
    //for (json::iterator it = data2.begin(); it != data2.end(); ++it) {
    //    // std::cout << "CreatureDusplayInfo.dbc add" << it.key() << " " <<it.value() << '\n';
    //    CreatureDusplayInfoChange[stringToUInt(it.key())] = it.value();
    //}
    /////////////////////
    //std::ifstream f3("./jsons/ItemDisplayInfo.dbc.json");
    //json data3 = json::parse(f3);
    //for (json::iterator it = data3.begin(); it != data3.end(); ++it) {
    //    // std::cout << "ItemDisplayInfo.dbc add" << it.key() << " " <<it.value() << '\n';
    //    ItemDisplayInfoChange[stringToUInt(it.key())] = it.value();
    //}
    /////////////////////
    //std::ifstream f4("./jsons/SpellItemEnchantment.dbc.json");
    //json data4 = json::parse(f4);
    //for (json::iterator it = data4.begin(); it != data4.end(); ++it) {
    //    // std::cout << "Spell.dbc add" << it.key() << " " <<it.value() << '\n';
    //    SpellItemEnchantmentChange[stringToUInt(it.key())] = it.value();
    //}
    /////////////////////
    return true;
};

wchar_t* ConverterToWChar(const char* orig) {
    //const char* orig = "./patch-ruRU-4.mpq";
    size_t newsize = strlen(orig) + 1;
    wchar_t* wcstring = new wchar_t[newsize];

    // Convert char* string to a wchar_t* string.
    size_t convertedChars = 0;
    mbstowcs_s(&convertedChars, wcstring, newsize, orig, _TRUNCATE);
    // Display the result and indicate the type of string that it is.
    //wcout << wcstring << L" (wchar_t *)" << endl;
    //delete[] wcstring;


    return wcstring;
}




bool ExtractMPQ(std::string path = "error") {
    //std::cout << "*****************************ExtractMPQ********************************\n";
    HANDLE mpq;
    //std::cout << "SFileOpenArchive start" << std::endl;
    SFileOpenArchive(ConverterToWChar((path+ std::string("/Data/ruRU/patch-ruRU-4.mpq")).c_str()), 0, STREAM_FLAG_WRITE_SHARE, &mpq);
    // std::cout<< "SFileOpenArchive error " << GetLastError() << std::endl;
    if (mpq) {

        //std::cout << "SFileExtractFile Spell.dbc" << std::endl;
        SFileExtractFile(mpq, "DBFilesClient\\Spell.dbc", ConverterToWChar("./Spell.dbc"), SFILE_OPEN_FROM_MPQ);
        //std::cout << "SFileExtractFile ItemDisplayInfo.dbc" << std::endl;
        SFileExtractFile(mpq, "DBFilesClient\\ItemDisplayInfo.dbc", ConverterToWChar("./ItemDisplayInfo.dbc"), SFILE_OPEN_FROM_MPQ);
        //std::cout << "SFileExtractFile SpellItemEnchantment.dbc" << std::endl;
        SFileExtractFile(mpq, "DBFilesClient\\SpellItemEnchantment.dbc", ConverterToWChar("./SpellItemEnchantment.dbc"), SFILE_OPEN_FROM_MPQ);
        //std::cout << SFileCloseArchive(mpq) << std::endl;
        return true;
        //std::cout << "*****************************ExtractMPQ********************************\n";
    }
    return false;

};

bool ChangeSpellDBC(std::string path = "error") {
    //std::cout << "*****************************ChangeSpellDBC********************************\n";
    //std::cout << "Spell.dbc format:\n";

    DBCSpell.Load("./Spell.dbc");
    if (!DBCSpell.getNumFields()) {
        //std::cout << "ERROR: Can not open file: " << "./DBFilesClient/Spell.dbc" << std::endl;
        return false;
    }
    else {
        //std::cout << "./DBFilesClient/Spell.dbc" << " - Opened successful." << std::endl << "./DBFilesClient/Spell.dbc" << " - fields: "
            //<< DBCSpell.getNumFields() << ", rows: " << DBCSpell.getNumRows() << std::endl;
    }

    //std::cout << "./DBFilesClient/Spell.dbc" << " - DBC format: OK." << "\n";

    FILE* npf = fopen("./Spell.dbc", "wb");
    fwrite(&DBCSpell.header, 4, 1, npf);

    fwrite(&DBCSpell.recordCount, 4, 1, npf);

    fwrite(&DBCSpell.fieldCount, 4, 1, npf);

    fwrite(&DBCSpell.recordSize, 4, 1, npf);

    fwrite(&DBCSpell.stringSize, 4, 1, npf);


    for (uint32 i = 0; i < DBCSpell.recordCount; i++) {
        auto record = DBCSpell.getRecord(i);
        int spellid = record.getInt32(0);
        const char* spellNameGetet = record.getString(136);
        std::string spellName(spellNameGetet);
        uint32 spellVisualID = record.getUInt32(131);

        if (SpellChange.count(spellid)) {
            // std::cout<< "spellid->("<< spellid <<") spellname->("<< spellName <<") SpellChange->("<< spellVisualID<<") changed SpellChange to " << SpellChange[spellVisualID]<< std::endl;
            // std::cout<< "spell id- > "<<spellid << "  spell visual -> " << spellVisualID << " changed to "<< SpellChange[spellid] << std::endl;
            record.setUInt32(131, SpellChange[spellid]);
        }
    }


    fwrite(DBCSpell.data, DBCSpell.recordSize * DBCSpell.recordCount + DBCSpell.stringSize, 1, npf);

    fwrite(DBCSpell.stringTable, DBCSpell.stringSize, 0, npf);


    fclose(npf);
    //std::cout << "./DBFilesClient/Spell.dbc" << " -> Spell.dbc: OK." << "\n\n";
    //std::cout << "****************************ChangeSpellDBC**********************************\n\n\n";
    return true;
}

bool ChangeCreatureDisplayInfoDBC(std::string path = "da") {
    //std::cout << "******************************ChangeCreatureDisplayInfoDBC********************************\n";
    //std::cout << "CreatureDusplayInfo.dbc format:\n";

    DBCCreatureDusplayInfo.Load("./CreatureDisplayInfo.dbc");
    //std::cout << "******************************ChangeCreatureDisplayInfoDBC**************************\n\n\n";
    return true;
};

bool ChangeItemDisplayInfoDBC(std::string path = "da") {
    //std::cout << "*****************************ChangeItemDisplayInfoDBC********************************\n";
    //std::cout << "ItemDisplayInfo.dbc format:\n";

    DBCItemDisplayInfo.Load("./ItemDisplayInfo.dbc");
    if (!DBCItemDisplayInfo.getNumFields()) {
        //std::cout << "ERROR: Can not open file: " << "./DBFilesClient/ItemDisplayInfo.dbc" << std::endl;
        return false;
    }
    else {
        //std::cout << "./DBFilesClient/ItemDisplayInfo.dbc" << " - Opened successful." << std::endl << "./DBFilesClient/ItemDisplayInfo.dbc" << " - fields: "
            //<< DBCItemDisplayInfo.getNumFields() << ", rows: " << DBCItemDisplayInfo.getNumRows() << std::endl;
    }
    for (uint32 i = 0; i < DBCItemDisplayInfo.recordCount; i++) {
        auto record = DBCItemDisplayInfo.getRecord(i);

        record.setUInt32(23, 0);
        record.setUInt32(11, 0);

    }
    FILE* npf = fopen("./ItemDisplayInfo.dbc", "wb");

    fwrite(&DBCItemDisplayInfo.header, 4, 1, npf);

    fwrite(&DBCItemDisplayInfo.recordCount, 4, 1, npf);

    fwrite(&DBCItemDisplayInfo.fieldCount, 4, 1, npf);

    fwrite(&DBCItemDisplayInfo.recordSize, 4, 1, npf);

    fwrite(&DBCItemDisplayInfo.stringSize, 4, 1, npf);
    fwrite(DBCItemDisplayInfo.data, DBCItemDisplayInfo.recordSize * DBCItemDisplayInfo.recordCount + DBCItemDisplayInfo.stringSize, 1, npf);

    fwrite(DBCItemDisplayInfo.stringTable, DBCItemDisplayInfo.stringSize, 0, npf);
    fclose(npf);

    //std::cout << "./DBFilesClient/ItemDisplayInfo.dbc" << " -> ItemDisplayInfo.dbc: OK." << "\n\n";
    //std::cout << "**********************************ChangeItemDisplayInfoDBC*****************************\n\n\n";
    return true;
}

bool ChangeSpellItemEnchantmentDBC(std::string path = "error") {
    //std::cout << "**************************ChangeSpellItemEnchantmentDBC****************************\n";
    //std::cout << "SpellItemEnchantment.dbc format:\n";

    DBCSpellItemEnchantment.Load("./SpellItemEnchantment.dbc");
    if (!DBCSpellItemEnchantment.getNumFields()) {
        //std::cout << "ERROR: Can not open file: " << "./DBFilesClient/SpellItemEnchantment.dbc" << std::endl;
        return false;
    }
    else {
        //std::cout << "./DBFilesClient/SpellItemEnchantment.dbc" << " - Opened successful." << std::endl << "./DBFilesClient/SpellItemEnchantment.dbc" << " - fields: "
            //<< DBCSpellItemEnchantment.getNumFields() << ", rows: " << DBCSpellItemEnchantment.getNumRows() << std::endl;
    }
    for (uint32 i = 0; i < DBCSpellItemEnchantment.recordCount; i++) {
        auto record = DBCSpellItemEnchantment.getRecord(i);
        record.setUInt32(31, 0);
    }

    FILE* npf = fopen("./SpellItemEnchantment.dbc", "wb");

    fwrite(&DBCSpellItemEnchantment.header, 4, 1, npf);

    fwrite(&DBCSpellItemEnchantment.recordCount, 4, 1, npf);

    fwrite(&DBCSpellItemEnchantment.fieldCount, 4, 1, npf);

    fwrite(&DBCSpellItemEnchantment.recordSize, 4, 1, npf);

    fwrite(&DBCSpellItemEnchantment.stringSize, 4, 1, npf);
    fwrite(DBCSpellItemEnchantment.data, DBCSpellItemEnchantment.recordSize * DBCSpellItemEnchantment.recordCount + DBCSpellItemEnchantment.stringSize, 1, npf);

    fwrite(DBCSpellItemEnchantment.stringTable, DBCSpellItemEnchantment.stringSize, 0, npf);
    fclose(npf);

    //std::cout << "./DBFilesClient/SpellItemEnchantment.dbc" << " -> SpellItemEnchantment.dbc: OK." << "\n\n";
    //std::cout << "***********************************ChangeSpellItemEnchantmentDBC*******************************\n\n\n";
    return true;
}


bool CreateMPQ(std::string path = "error") {
    //std::cout << "**********************************CreateMPQ************************************\n\n\n";
    HANDLE mpq;
    remove((path + std::string("/Data/ruRU/patch-ruRU-x.mpq")).c_str());
    SFileCreateArchive(ConverterToWChar((path + std::string("/Data/ruRU/patch-ruRU-x.mpq")).c_str()), MPQ_CREATE_ATTRIBUTES + MPQ_CREATE_ARCHIVE_V2, 0x000000010, &mpq);

    SFileAddFileEx(mpq, ConverterToWChar("./Spell.dbc"), "DBFilesClient\\Spell.dbc", MPQ_FILE_COMPRESS + MPQ_FILE_REPLACEEXISTING, MPQ_COMPRESSION_ZLIB, MPQ_COMPRESSION_NEXT_SAME);
    remove("./Spell.dbc");
    //std::cout << "added Spell.dbc" << std::endl;
    SFileAddFileEx(mpq, ConverterToWChar("./ItemDisplayInfo.dbc"), "DBFilesClient\\ItemDisplayInfo.dbc", MPQ_FILE_COMPRESS + MPQ_FILE_REPLACEEXISTING, MPQ_COMPRESSION_ZLIB, MPQ_COMPRESSION_NEXT_SAME);
    //std::cout << "added ItemDisplayInfo.dbc" << std::endl;
    remove("./ItemDisplayInfo.dbc");
    SFileAddFileEx(mpq, ConverterToWChar("./SpellItemEnchantment.dbc"), "DBFilesClient\\SpellItemEnchantment.dbc", MPQ_FILE_COMPRESS + MPQ_FILE_REPLACEEXISTING, MPQ_COMPRESSION_ZLIB, MPQ_COMPRESSION_NEXT_SAME);
    //std::cout << "added SpellItemEnchantment.dbc" << std::endl;
    remove("./SpellItemEnchantment.dbc");
    //std::cout << "End create MPQ" << std::endl;

    SFileCloseArchive(mpq);
    //std::cout << "*********************************CreateMPQ**********************************\n\n\n";
    return true;
};

#endif