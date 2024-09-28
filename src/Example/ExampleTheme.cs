﻿using System.Numerics;
using ImGuiNET;

namespace ModName.Example;

public static class ExampleTheme
{
    public static void SetTheme()
    {
        // Get the current ImGui style
        var style = ImGui.GetStyle();
        
        // Define color values using ImVec4
        style.Colors[(int)ImGuiCol.Text]                     = new Vector4(1.00f, 1.00f, 1.00f, 1.00f);
        style.Colors[(int)ImGuiCol.TextDisabled]             = new Vector4(0.50f, 0.50f, 0.50f, 1.00f);
        style.Colors[(int)ImGuiCol.WindowBg]                 = new Vector4(0.10f, 0.10f, 0.10f, 1.00f);
        style.Colors[(int)ImGuiCol.ChildBg]                  = new Vector4(0.00f, 0.00f, 0.00f, 0.00f);
        style.Colors[(int)ImGuiCol.PopupBg]                  = new Vector4(0.19f, 0.19f, 0.19f, 0.92f);
        style.Colors[(int)ImGuiCol.Border]                   = new Vector4(0.19f, 0.19f, 0.19f, 0.29f);
        style.Colors[(int)ImGuiCol.BorderShadow]             = new Vector4(0.00f, 0.00f, 0.00f, 0.24f);
        style.Colors[(int)ImGuiCol.FrameBg]                  = new Vector4(0.05f, 0.05f, 0.05f, 0.54f);
        style.Colors[(int)ImGuiCol.FrameBgHovered]           = new Vector4(0.19f, 0.19f, 0.19f, 0.54f);
        style.Colors[(int)ImGuiCol.FrameBgActive]            = new Vector4(0.20f, 0.22f, 0.23f, 1.00f);
        style.Colors[(int)ImGuiCol.TitleBg]                  = new Vector4(0.00f, 0.00f, 0.00f, 1.00f);
        style.Colors[(int)ImGuiCol.TitleBgActive]            = new Vector4(0.06f, 0.06f, 0.06f, 1.00f);
        style.Colors[(int)ImGuiCol.TitleBgCollapsed]         = new Vector4(0.00f, 0.00f, 0.00f, 1.00f);
        style.Colors[(int)ImGuiCol.MenuBarBg]                = new Vector4(0.14f, 0.14f, 0.14f, 1.00f);
        style.Colors[(int)ImGuiCol.ScrollbarBg]              = new Vector4(0.05f, 0.05f, 0.05f, 0.54f);
        style.Colors[(int)ImGuiCol.ScrollbarGrab]            = new Vector4(0.34f, 0.34f, 0.34f, 0.54f);
        style.Colors[(int)ImGuiCol.ScrollbarGrabHovered]     = new Vector4(0.40f, 0.40f, 0.40f, 0.54f);
        style.Colors[(int)ImGuiCol.ScrollbarGrabActive]      = new Vector4(0.56f, 0.56f, 0.56f, 0.54f);
        style.Colors[(int)ImGuiCol.CheckMark]                = new Vector4(0.33f, 0.67f, 0.86f, 1.00f);
        style.Colors[(int)ImGuiCol.SliderGrab]               = new Vector4(0.34f, 0.34f, 0.34f, 0.54f);
        style.Colors[(int)ImGuiCol.SliderGrabActive]         = new Vector4(0.56f, 0.56f, 0.56f, 0.54f);
        style.Colors[(int)ImGuiCol.Button]                   = new Vector4(0.05f, 0.05f, 0.05f, 0.54f);
        style.Colors[(int)ImGuiCol.ButtonHovered]            = new Vector4(0.19f, 0.19f, 0.19f, 0.54f);
        style.Colors[(int)ImGuiCol.ButtonActive]             = new Vector4(0.20f, 0.22f, 0.23f, 1.00f);
        style.Colors[(int)ImGuiCol.Header]                   = new Vector4(0.00f, 0.00f, 0.00f, 0.52f);
        style.Colors[(int)ImGuiCol.HeaderHovered]            = new Vector4(0.00f, 0.00f, 0.00f, 0.36f);
        style.Colors[(int)ImGuiCol.HeaderActive]             = new Vector4(0.20f, 0.22f, 0.23f, 0.33f);
        style.Colors[(int)ImGuiCol.Separator]                = new Vector4(0.28f, 0.28f, 0.28f, 0.29f);
        style.Colors[(int)ImGuiCol.SeparatorHovered]         = new Vector4(0.44f, 0.44f, 0.44f, 0.29f);
        style.Colors[(int)ImGuiCol.SeparatorActive]          = new Vector4(0.40f, 0.44f, 0.47f, 1.00f);
        style.Colors[(int)ImGuiCol.ResizeGrip]               = new Vector4(0.28f, 0.28f, 0.28f, 0.29f);
        style.Colors[(int)ImGuiCol.ResizeGripHovered]        = new Vector4(0.44f, 0.44f, 0.44f, 0.29f);
        style.Colors[(int)ImGuiCol.ResizeGripActive]         = new Vector4(0.40f, 0.44f, 0.47f, 1.00f);
        style.Colors[(int)ImGuiCol.Tab]                      = new Vector4(0.00f, 0.00f, 0.00f, 0.52f);
        style.Colors[(int)ImGuiCol.TabHovered]               = new Vector4(0.14f, 0.14f, 0.14f, 1.00f);
        style.Colors[(int)ImGuiCol.TabSelected]              = new Vector4(0.20f, 0.20f, 0.20f, 0.36f); //TabActive
        style.Colors[(int)ImGuiCol.TabDimmed]                = new Vector4(0.00f, 0.00f, 0.00f, 0.52f); //TabUnfocused
        style.Colors[(int)ImGuiCol.TabDimmedSelected]        = new Vector4(0.14f, 0.14f, 0.14f, 1.00f); //TabUnfocusedActive
        style.Colors[(int)ImGuiCol.DockingPreview]           = new Vector4(0.33f, 0.67f, 0.86f, 1.00f);
        style.Colors[(int)ImGuiCol.DockingEmptyBg]           = new Vector4(1.00f, 0.00f, 0.00f, 1.00f);
        style.Colors[(int)ImGuiCol.PlotLines]                = new Vector4(1.00f, 0.00f, 0.00f, 1.00f);
        style.Colors[(int)ImGuiCol.PlotLinesHovered]         = new Vector4(1.00f, 0.00f, 0.00f, 1.00f);
        style.Colors[(int)ImGuiCol.PlotHistogram]            = new Vector4(1.00f, 0.00f, 0.00f, 1.00f);
        style.Colors[(int)ImGuiCol.PlotHistogramHovered]     = new Vector4(1.00f, 0.00f, 0.00f, 1.00f);
        style.Colors[(int)ImGuiCol.TableHeaderBg]            = new Vector4(0.00f, 0.00f, 0.00f, 0.52f);
        style.Colors[(int)ImGuiCol.TableBorderStrong]        = new Vector4(0.00f, 0.00f, 0.00f, 0.52f);
        style.Colors[(int)ImGuiCol.TableBorderLight]         = new Vector4(0.28f, 0.28f, 0.28f, 0.29f);
        style.Colors[(int)ImGuiCol.TableRowBg]               = new Vector4(0.00f, 0.00f, 0.00f, 0.00f);
        style.Colors[(int)ImGuiCol.TableRowBgAlt]            = new Vector4(1.00f, 1.00f, 1.00f, 0.06f);
        style.Colors[(int)ImGuiCol.TextSelectedBg]           = new Vector4(0.20f, 0.22f, 0.23f, 1.00f);
        style.Colors[(int)ImGuiCol.DragDropTarget]           = new Vector4(0.33f, 0.67f, 0.86f, 1.00f);
        style.Colors[(int)ImGuiCol.NavHighlight]             = new Vector4(1.00f, 0.00f, 0.00f, 1.00f);
        style.Colors[(int)ImGuiCol.NavWindowingHighlight]    = new Vector4(1.00f, 0.00f, 0.00f, 0.70f);
        style.Colors[(int)ImGuiCol.NavWindowingDimBg]        = new Vector4(1.00f, 0.00f, 0.00f, 0.20f);
        style.Colors[(int)ImGuiCol.ModalWindowDimBg]         = new Vector4(1.00f, 0.00f, 0.00f, 0.35f);
    
        // Set style parameters
        style.WindowPadding                 = new Vector2(8.00f, 8.00f);
        style.FramePadding                  = new Vector2(5.00f, 2.00f);
        style.CellPadding                   = new Vector2(6.00f, 6.00f);
        style.ItemSpacing                   = new Vector2(6.00f, 6.00f);
        style.ItemInnerSpacing              = new Vector2(6.00f, 6.00f);
        style.TouchExtraPadding             = new Vector2(0.00f, 0.00f);
        style.IndentSpacing                 = 25;
        style.ScrollbarSize                 = 15;
        style.GrabMinSize                   = 10;
        style.WindowBorderSize              = 1;
        style.ChildBorderSize               = 1;
        style.PopupBorderSize               = 1;
        style.FrameBorderSize               = 1;
        style.TabBorderSize                 = 1;
        style.WindowRounding                = 7;
        style.ChildRounding                 = 4;
        style.FrameRounding                 = 3;
        style.PopupRounding                 = 4;
        style.ScrollbarRounding             = 9;
        style.GrabRounding                  = 3;
        style.LogSliderDeadzone             = 4;
        style.TabRounding                   = 4;
    }
}